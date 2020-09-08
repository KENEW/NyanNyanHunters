

//=============================================================
//||                   Generated by BansheeGz Code Generator ||
//=============================================================

namespace BansheeGz.BGDatabase.Example
{
	
		//=============================================================
		//||                   Generated by BansheeGz Code Generator ||
		//=============================================================

		public partial class R : BGDna
		{
			private static R i_n_s_t_a_n_c_e;
			public static R I
			{
				get
				{
					if (i_n_s_t_a_n_c_e==null)
					{
						i_n_s_t_a_n_c_e = new R();
						Bind(true);
						BGRepo.OnLoad += Bind;
					}
					return i_n_s_t_a_n_c_e;
				}
			}
			public static BGD_Player Player
			{
				get
				{
					return I._Player;
				}
			}
			public static BGD_Scene Scene
			{
				get
				{
					return I._Scene;
				}
			}
			public static BGD_Collectable Collectable
			{
				get
				{
					return I._Collectable;
				}
			}
			public static BGD_CollectableType CollectableType
			{
				get
				{
					return I._CollectableType;
				}
			}
			public BGD_Player _Player;
			public BGD_Scene _Scene;
			public BGD_Collectable _Collectable;
			public BGD_CollectableType _CollectableType;
			public R()
			{
				_Player = new BGD_Player(this);
				_Scene = new BGD_Scene(this);
				_Collectable = new BGD_Collectable(this);
				_CollectableType = new BGD_CollectableType(this);
			}
			public static void Bind(bool success)
			{
				i_n_s_t_a_n_c_e.Bind(BGRepo.I);
			}
		}

	
		//=============================================================
		//||                   Generated by BansheeGz Code Generator ||
		//=============================================================

		public partial class BGD_Player : BGDnaMeta
		{
			public BGDnaField<System.String> d_name;
			public BGDnaField<System.Int32> d_gold;
			public BGDnaField<UnityEngine.Vector3> d_position;
			public BGDnaField<UnityEngine.Quaternion> d_rotation;
			public BGDnaField<BansheeGz.BGDatabase.BGEntity> d_scene;
			public BGD_Player(BGDna dna) : base(dna, "Player")
			{
				d_name = new BGDnaField<System.String>(this, "name");
				d_gold = new BGDnaField<System.Int32>(this, "gold");
				d_position = new BGDnaField<UnityEngine.Vector3>(this, "position");
				d_rotation = new BGDnaField<UnityEngine.Quaternion>(this, "rotation");
				d_scene = new BGDnaField<BansheeGz.BGDatabase.BGEntity>(this, "scene");
			}
		}

	
		//=============================================================
		//||                   Generated by BansheeGz Code Generator ||
		//=============================================================

		public partial class BGD_Scene : BGDnaMeta
		{
			public BGDnaField<System.String> d_name;
			public BGDnaField<System.Collections.Generic.List<BansheeGz.BGDatabase.BGEntity>> d_Collectable;
			public BGDnaField<UnityEngine.Vector3> d_spawnPosition;
			public BGDnaField<UnityEngine.Vector3> d_spawnRotation;
			public BGDnaField<UnityEngine.Bounds> d_bounds;
			public BGD_Scene(BGDna dna) : base(dna, "Scene")
			{
				d_name = new BGDnaField<System.String>(this, "name");
				d_Collectable = new BGDnaField<System.Collections.Generic.List<BansheeGz.BGDatabase.BGEntity>>(this, "Collectable");
				d_spawnPosition = new BGDnaField<UnityEngine.Vector3>(this, "spawnPosition");
				d_spawnRotation = new BGDnaField<UnityEngine.Vector3>(this, "spawnRotation");
				d_bounds = new BGDnaField<UnityEngine.Bounds>(this, "bounds");
			}
		}

	
		//=============================================================
		//||                   Generated by BansheeGz Code Generator ||
		//=============================================================

		public partial class BGD_Collectable : BGDnaMeta
		{
			public BGDnaField<System.String> d_name;
			public BGDnaField<BansheeGz.BGDatabase.BGEntity> d_Scene;
			public BGDnaField<BansheeGz.BGDatabase.BGEntity> d_type;
			public BGDnaField<UnityEngine.Vector3> d_position;
			public BGDnaField<System.Int32> d_gold;
			public BGD_Collectable(BGDna dna) : base(dna, "Collectable")
			{
				d_name = new BGDnaField<System.String>(this, "name");
				d_Scene = new BGDnaField<BansheeGz.BGDatabase.BGEntity>(this, "Scene");
				d_type = new BGDnaField<BansheeGz.BGDatabase.BGEntity>(this, "type");
				d_position = new BGDnaField<UnityEngine.Vector3>(this, "position");
				d_gold = new BGDnaField<System.Int32>(this, "gold");
			}
		}

	
		//=============================================================
		//||                   Generated by BansheeGz Code Generator ||
		//=============================================================

		public partial class BGD_CollectableType : BGDnaMeta
		{
			public BGDnaField<System.String> d_name;
			public BGDnaField<UnityEngine.GameObject> d_prefab;
			public BGDnaField<UnityEngine.AudioClip> d_audio;
			public BGD_CollectableType(BGDna dna) : base(dna, "CollectableType")
			{
				d_name = new BGDnaField<System.String>(this, "name");
				d_prefab = new BGDnaField<UnityEngine.GameObject>(this, "prefab");
				d_audio = new BGDnaField<UnityEngine.AudioClip>(this, "audio");
			}
		}

}
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class QueryHBaseHaDBResponseBody : TeaModel {
        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public QueryHBaseHaDBResponseBodyClusterList ClusterList { get; set; }
        public class QueryHBaseHaDBResponseBodyClusterList : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<QueryHBaseHaDBResponseBodyClusterListCluster> Cluster { get; set; }
            public class QueryHBaseHaDBResponseBodyClusterListCluster : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>hb-t4nn7dy1u1etbzmzm</para>
                /// </summary>
                [NameInMap("ActiveName")]
                [Validation(Required=false)]
                public string ActiveName { get; set; }

                /// <summary>
                /// <para>bdsId</para>
                /// 
                /// <b>Example:</b>
                /// <para>bds-t4n3496whj23ia4k</para>
                /// </summary>
                [NameInMap("BdsName")]
                [Validation(Required=false)]
                public string BdsName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ha-v21tmnxjwh2yuy1il</para>
                /// </summary>
                [NameInMap("HaName")]
                [Validation(Required=false)]
                public string HaName { get; set; }

                [NameInMap("HaSlbConnList")]
                [Validation(Required=false)]
                public QueryHBaseHaDBResponseBodyClusterListClusterHaSlbConnList HaSlbConnList { get; set; }
                public class QueryHBaseHaDBResponseBodyClusterListClusterHaSlbConnList : TeaModel {
                    [NameInMap("HaSlbConn")]
                    [Validation(Required=false)]
                    public List<QueryHBaseHaDBResponseBodyClusterListClusterHaSlbConnListHaSlbConn> HaSlbConn { get; set; }
                    public class QueryHBaseHaDBResponseBodyClusterListClusterHaSlbConnListHaSlbConn : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Standby</para>
                        /// </summary>
                        [NameInMap("HbaseType")]
                        [Validation(Required=false)]
                        public string HbaseType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ha-v21tmnxjwh2yuy1il-phoenix.bds.9b78df04-b.rds.aliyuncs.com:8765</para>
                        /// </summary>
                        [NameInMap("SlbConnAddr")]
                        [Validation(Required=false)]
                        public string SlbConnAddr { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>phoenix</para>
                        /// </summary>
                        [NameInMap("SlbType")]
                        [Validation(Required=false)]
                        public string SlbType { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hb-t4n0ye37832tx22vz</para>
                /// </summary>
                [NameInMap("StandbyName")]
                [Validation(Required=false)]
                public string StandbyName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>963355AD-A3B1-4654-AFFC-B5186EB8F889</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

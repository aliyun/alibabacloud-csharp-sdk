// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetDeployGraphResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result returned
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDeployGraphResponseBodyResult Result { get; set; }
        public class GetDeployGraphResponseBodyResult : TeaModel {
            [NameInMap("graph")]
            [Validation(Required=false)]
            public GetDeployGraphResponseBodyResultGraph Graph { get; set; }
            public class GetDeployGraphResponseBodyResultGraph : TeaModel {
                /// <summary>
                /// 索引元信息
                /// </summary>
                [NameInMap("indexMetas")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphIndexMetas> IndexMetas { get; set; }
                public class GetDeployGraphResponseBodyResultGraphIndexMetas : TeaModel {
                    [NameInMap("domainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("tableDeployId")]
                    [Validation(Required=false)]
                    public long? TableDeployId { get; set; }

                    [NameInMap("tableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    [NameInMap("zoneName")]
                    [Validation(Required=false)]
                    public string ZoneName { get; set; }

                }

                /// <summary>
                /// 在线集群元信息
                /// </summary>
                [NameInMap("onlineMaster")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphOnlineMaster> OnlineMaster { get; set; }
                public class GetDeployGraphResponseBodyResultGraphOnlineMaster : TeaModel {
                    [NameInMap("domainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    [NameInMap("hippoId")]
                    [Validation(Required=false)]
                    public string HippoId { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// 数据源和索引关联关系
                /// </summary>
                [NameInMap("tableIndexRelation")]
                [Validation(Required=false)]
                public Dictionary<string, List<string>> TableIndexRelation { get; set; }

                /// <summary>
                /// 数据源元信息
                /// </summary>
                [NameInMap("tableMetas")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphTableMetas> TableMetas { get; set; }
                public class GetDeployGraphResponseBodyResultGraphTableMetas : TeaModel {
                    [NameInMap("buildDeployId")]
                    [Validation(Required=false)]
                    public long? BuildDeployId { get; set; }

                    [NameInMap("domainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("tableDeployId")]
                    [Validation(Required=false)]
                    public long? TableDeployId { get; set; }

                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// zone和索引关联关系
                /// </summary>
                [NameInMap("zoneIndexRelation")]
                [Validation(Required=false)]
                public Dictionary<string, List<string>> ZoneIndexRelation { get; set; }

                /// <summary>
                /// zone元信息
                /// </summary>
                [NameInMap("zoneMetas")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphZoneMetas> ZoneMetas { get; set; }
                public class GetDeployGraphResponseBodyResultGraphZoneMetas : TeaModel {
                    [NameInMap("domainInfo")]
                    [Validation(Required=false)]
                    public string DomainInfo { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("suezAdminName")]
                    [Validation(Required=false)]
                    public string SuezAdminName { get; set; }

                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}

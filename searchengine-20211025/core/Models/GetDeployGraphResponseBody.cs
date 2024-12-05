// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetDeployGraphResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7B7D598-B080-5C8E-AA35-D43EC0D5F886</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDeployGraphResponseBodyResult Result { get; set; }
        public class GetDeployGraphResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The deployment information.</para>
            /// </summary>
            [NameInMap("graph")]
            [Validation(Required=false)]
            public GetDeployGraphResponseBodyResultGraph Graph { get; set; }
            public class GetDeployGraphResponseBodyResultGraph : TeaModel {
                /// <summary>
                /// <para>The index metadata.</para>
                /// </summary>
                [NameInMap("indexMetas")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphIndexMetas> IndexMetas { get; set; }
                public class GetDeployGraphResponseBodyResultGraphIndexMetas : TeaModel {
                    /// <summary>
                    /// <para>The name of the data center.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hz_pre_vpc_domain_1</para>
                    /// </summary>
                    [NameInMap("domainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    /// <summary>
                    /// <para>The index name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_api</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The deployment ID of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2409</para>
                    /// </summary>
                    [NameInMap("tableDeployId")]
                    [Validation(Required=false)]
                    public long? TableDeployId { get; set; }

                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-pl32rf0****_test_api</para>
                    /// </summary>
                    [NameInMap("tableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <para>The tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_api_hz_pre_vpc_domain_1</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The name of the QRS worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-pl32rf0****_qrs</para>
                    /// </summary>
                    [NameInMap("zoneName")]
                    [Validation(Required=false)]
                    public string ZoneName { get; set; }

                }

                /// <summary>
                /// <para>The metadata of online clusters.</para>
                /// </summary>
                [NameInMap("onlineMaster")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphOnlineMaster> OnlineMaster { get; set; }
                public class GetDeployGraphResponseBodyResultGraphOnlineMaster : TeaModel {
                    /// <summary>
                    /// <para>The name of the data center.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hz_pre_vpc_domain_1</para>
                    /// </summary>
                    [NameInMap("domainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    /// <summary>
                    /// <para>The resource ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5377</para>
                    /// </summary>
                    [NameInMap("hippoId")]
                    [Validation(Required=false)]
                    public string HippoId { get; set; }

                    /// <summary>
                    /// <para>The ID of the data center.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the online cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-pl32rf0****_hz_pre_vpc_domain_1</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The association relationships between data sources and indexes.</para>
                /// </summary>
                [NameInMap("tableIndexRelation")]
                [Validation(Required=false)]
                public Dictionary<string, List<string>> TableIndexRelation { get; set; }

                /// <summary>
                /// <para>The metadata of data sources.</para>
                /// </summary>
                [NameInMap("tableMetas")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphTableMetas> TableMetas { get; set; }
                public class GetDeployGraphResponseBodyResultGraphTableMetas : TeaModel {
                    /// <summary>
                    /// <para>The ID of the offline deployment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("buildDeployId")]
                    [Validation(Required=false)]
                    public long? BuildDeployId { get; set; }

                    /// <summary>
                    /// <para>The name of the data center.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hz_pre_vpc_domain_1</para>
                    /// </summary>
                    [NameInMap("domainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-pl32rf0****_test_api</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The deployment ID of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2177</para>
                    /// </summary>
                    [NameInMap("tableDeployId")]
                    [Validation(Required=false)]
                    public long? TableDeployId { get; set; }

                    /// <summary>
                    /// <para>The tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-pl32rf0****_test_api_hz_pre_vpc_domain_1</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The type of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The association relationships between zones and indexes.</para>
                /// </summary>
                [NameInMap("zoneIndexRelation")]
                [Validation(Required=false)]
                public Dictionary<string, List<string>> ZoneIndexRelation { get; set; }

                /// <summary>
                /// <para>The zone metadata.</para>
                /// </summary>
                [NameInMap("zoneMetas")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphZoneMetas> ZoneMetas { get; set; }
                public class GetDeployGraphResponseBodyResultGraphZoneMetas : TeaModel {
                    /// <summary>
                    /// <para>The name of the data center.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hz_pre_vpc_domain_1</para>
                    /// </summary>
                    [NameInMap("domainInfo")]
                    [Validation(Required=false)]
                    public string DomainInfo { get; set; }

                    /// <summary>
                    /// <para>The name of the Query Result Searcher (QRS) worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-pl32rf0****_qrs</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The name of the service that is used to manage the relationships between online clusters and indexes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-pl32rf0****_hz_pre_vpc_domain_1</para>
                    /// </summary>
                    [NameInMap("suezAdminName")]
                    [Validation(Required=false)]
                    public string SuezAdminName { get; set; }

                    /// <summary>
                    /// <para>The tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-pl32rf0****_qrs_hz_pre_vpc_domain_1</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The node type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qrs</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}

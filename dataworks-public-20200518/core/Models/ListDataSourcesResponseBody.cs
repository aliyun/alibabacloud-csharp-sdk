// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The query result returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataSourcesResponseBodyData Data { get; set; }
        public class ListDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data sources.</para>
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<ListDataSourcesResponseBodyDataDataSources> DataSources { get; set; }
            public class ListDataSourcesResponseBodyDataDataSources : TeaModel {
                /// <summary>
                /// <para>The ID of the compute engine with which the data source is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("BindingCalcEngineId")]
                [Validation(Required=false)]
                public long? BindingCalcEngineId { get; set; }

                /// <summary>
                /// <para>The status of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: The data source is accessible.</description></item>
                /// <item><description>2: The data source is inaccessible.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConnectStatus")]
                [Validation(Required=false)]
                public int? ConnectStatus { get; set; }

                /// <summary>
                /// <para>The data connection string. The value of this parameter is in the JSON format. Examples of connection strings of common data sources:</para>
                /// <list type="bullet">
                /// <item><description><para>MaxCompute</para>
                /// <pre><c>{
                ///   &quot;pubEndpoint&quot;: &quot;http://service.cn.maxcompute.aliyun.com/api&quot;,
                ///   &quot;accessId&quot;: &quot;xxxxxxx&quot;,
                ///   &quot;securityToken&quot;: null,
                ///   &quot;endpoint&quot;: &quot;http://service.cn.maxcompute.aliyun-inc.com/api&quot;,
                ///   &quot;accessKey&quot;: &quot;***&quot;,
                ///   &quot;name&quot;: &quot;PRE_PROJECT_A_engine&quot;,
                ///   &quot;project&quot;: &quot;PRE_PROJECT_A&quot;,
                ///   &quot;vpcEndpoint&quot;: &quot;http://service.cn.maxcompute.aliyun-inc.com/api&quot;,
                ///   &quot;region&quot;: &quot;cn-shanghai&quot;,
                ///   &quot;authType&quot;: &quot;2&quot;
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>mysql</para>
                /// <pre><c>{
                ///   &quot;configType&quot;: &quot;1&quot;,
                ///   &quot;database&quot;: &quot;mysql_d111b&quot;,
                ///   &quot;instanceName&quot;: &quot;rm-xxxxxx&quot;,
                ///   &quot;password&quot;: &quot;***&quot;,
                ///   &quot;rdsOwnerId&quot;: &quot;12133xxxxxx&quot;,
                ///   &quot;tag&quot;: &quot;rds&quot;,
                ///   &quot;username&quot;: &quot;mysql_db111&quot;
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>sqlserver</para>
                /// <pre><c>{
                ///   &quot;configType&quot;: &quot;1&quot;,
                ///   &quot;jdbcUrl&quot;: &quot;jdbc:sqlserver://rm-xxxxx.sqlserver.rds.aliyuncs.com:1433;DatabaseName=sqlserver_db1&quot;,
                ///   &quot;password&quot;: &quot;***&quot;,
                ///   &quot;tag&quot;: &quot;public&quot;,
                ///   &quot;username&quot;: &quot;sqlserver_db111&quot;
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>oss</para>
                /// <pre><c>{
                ///   &quot;accessId&quot;: &quot;***********&quot;,
                ///   &quot;accessKey&quot;: &quot;***********&quot;,
                ///   &quot;bucket&quot;: &quot;bigxxx1223&quot;,
                ///   &quot;configType&quot;: &quot;1&quot;,
                ///   &quot;endpoint&quot;: &quot;http://oss-cn-hangzhou.aliyuncs.com&quot;,
                ///   &quot;tag&quot;: &quot;public&quot;
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>postgresql</para>
                /// <pre><c>{
                ///   &quot;configType&quot;: &quot;1&quot;,
                ///   &quot;database&quot;: &quot;cdp_xxx&quot;,
                ///   &quot;instanceName&quot;: &quot;rm-xxxx&quot;,
                ///   &quot;password&quot;: &quot;***&quot;,
                ///   &quot;rdsOwnerId&quot;: &quot;121xxxxx&quot;,
                ///   &quot;tag&quot;: &quot;rds&quot;,
                ///   &quot;username&quot;: &quot;cdp_xxx&quot;
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>ads</para>
                /// <pre><c>{
                ///   &quot;configType&quot;: &quot;1&quot;,
                ///   &quot;password&quot;: &quot;***&quot;,
                ///   &quot;schema&quot;: &quot;ads_demo&quot;,
                ///   &quot;tag&quot;: &quot;public&quot;,
                ///   &quot;url&quot;: &quot;ads-xxx-xxxx.cn-hangzhou-1.ads.aliyuncs.com:3029&quot;,
                ///   &quot;username&quot;: &quot;lslslsls&quot;
                /// }
                /// </c></pre>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;pubEndpoint&quot;:&quot;<a href="http://service.cn.maxcompute.aliyun.com/api%22,%22accessId%22:%22TMP.3KecGjvzy3i8MYfn2BGHgF7EHGyBFZcHm7GgngrABVRyvvKQrfF5kskR36xP361C3dqwbGo7SGYptAeGyiTwHXqLaBUvYC%22,%22securityToken%22:null,%22endpoint%22:%22http://service.cn.maxcompute.aliyun-inc.com/api%22,%22accessKey%22:%22***%22,%22name%22:%22PRE_PROJECT_A_engine%22,%22project%22:%22PRE_PROJECT_A%22,%22vpcEndpoint%22:%22http://service.cn.maxcompute.aliyun-inc.com/api%22,%22region%22:%22cn-shanghai%22,%22authType%22:%222%22%7D">http://service.cn.maxcompute.aliyun.com/api&quot;,&quot;accessId&quot;:&quot;TMP.3KecGjvzy3i8MYfn2BGHgF7EHGyBFZcHm7GgngrABVRyvvKQrfF5kskR36xP361C3dqwbGo7SGYptAeGyiTwHXqLaBUvYC&quot;,&quot;securityToken&quot;:null,&quot;endpoint&quot;:&quot;http://service.cn.maxcompute.aliyun-inc.com/api&quot;,&quot;accessKey&quot;:&quot;***&quot;,&quot;name&quot;:&quot;PRE_PROJECT_A_engine&quot;,&quot;project&quot;:&quot;PRE_PROJECT_A&quot;,&quot;vpcEndpoint&quot;:&quot;http://service.cn.maxcompute.aliyun-inc.com/api&quot;,&quot;region&quot;:&quot;cn-shanghai&quot;,&quot;authType&quot;:&quot;2&quot;}</a></para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The type of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>odps</description></item>
                /// <item><description>mysql</description></item>
                /// <item><description>rds</description></item>
                /// <item><description>oss</description></item>
                /// <item><description>sqlserver</description></item>
                /// <item><description>polardb</description></item>
                /// <item><description>oracle</description></item>
                /// <item><description>mongodb</description></item>
                /// <item><description>emr</description></item>
                /// <item><description>postgresql</description></item>
                /// <item><description>analyticdb_for_mysql</description></item>
                /// <item><description>hybriddb_for_postgresql</description></item>
                /// <item><description>holo</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("DataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                /// <summary>
                /// <para>Indicates whether the compute engine that is associated with the data source is the default compute engine used by data sources of the same type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DefaultEngine")]
                [Validation(Required=false)]
                public bool? DefaultEngine { get; set; }

                /// <summary>
                /// <para>The description of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a connection</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The environment in which the data source is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: development environment</description></item>
                /// <item><description>1: production environment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public int? EnvType { get; set; }

                /// <summary>
                /// <para>The time when the data source was created. Example: Mar 17, 2021 4:09:32 PM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mar 17, 2021 4:09:32 PM</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the data source was last modified. Example: Mar 17, 2021 4:09:32 PM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mar 17, 2021 4:09:32 PM</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to last modify the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>193543050****</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the data source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// <para>The sequence number of the data source. Data sources are sorted in descending order based on the value of this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

                /// <summary>
                /// <para>Indicates whether the data source is a shared data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Shared")]
                [Validation(Required=false)]
                public bool? Shared { get; set; }

                /// <summary>
                /// <para>The status of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: The data source is accessible.</description></item>
                /// <item><description>2: The data source is inaccessible.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The subtype of the data source. This parameter takes effect only when the DataSourceType parameter is set to rds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of data sources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>233</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc14115159376359****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

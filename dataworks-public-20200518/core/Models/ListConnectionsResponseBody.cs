// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query results for data sources that are returned on multiple pages.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListConnectionsResponseBodyData Data { get; set; }
        public class ListConnectionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data sources.</para>
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public List<ListConnectionsResponseBodyDataConnections> Connections { get; set; }
            public class ListConnectionsResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// <para>The ID of the compute engine with which the data source is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("BindingCalcEngineId")]
                [Validation(Required=false)]
                public int? BindingCalcEngineId { get; set; }

                /// <summary>
                /// <para>The status of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: The data source is normal.</description></item>
                /// <item><description>2: The data source is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConnectStatus")]
                [Validation(Required=false)]
                public int? ConnectStatus { get; set; }

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
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("ConnectionType")]
                [Validation(Required=false)]
                public string ConnectionType { get; set; }

                /// <summary>
                /// <para>The details of the data source. Examples of details of some common data sources:</para>
                /// <list type="bullet">
                /// <item><description>odps</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;accessId&quot;: &quot;xssssss&quot;,
                ///   &quot;accessKey&quot;: &quot;xsaxsaxsa&quot;,
                ///   &quot;authType&quot;: 2,
                ///   &quot;endpoint&quot;: &quot;http://service.odps.aliyun.com/api&quot;,
                ///   &quot;project&quot;: &quot;xsaxsax&quot;,
                ///   &quot;tag&quot;: &quot;public&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>mysql</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;database&quot;: &quot;xsaxsa&quot;,
                ///   &quot;instanceName&quot;: &quot;rm-xsaxsa&quot;,
                ///   &quot;password&quot;: &quot;xsaxsa&quot;,
                ///   &quot;rdsOwnerId&quot;: &quot;xasxsa&quot;,
                ///   &quot;regionId&quot;: &quot;cn-shanghai&quot;,
                ///   &quot;tag&quot;: &quot;rds&quot;,
                ///   &quot;username&quot;: &quot;xsaxsa&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>rds</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;configType&quot;: 1,
                ///   &quot;tag&quot;: &quot;rds&quot;,
                ///   &quot;database&quot;: &quot;xsaxsa&quot;,
                ///   &quot;username&quot;: &quot;xsaxsa&quot;,
                ///   &quot;password&quot;: &quot;xssaxsa$32050&quot;,
                ///   &quot;instanceName&quot;: &quot;rm-xsaxs&quot;,
                ///   &quot;rdsOwnerId&quot;: &quot;11111111&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>oss</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;accessId&quot;: &quot;sssssxx&quot;,
                ///   &quot;accessKey&quot;: &quot;xsaxaxsaxs&quot;,
                ///   &quot;bucket&quot;: &quot;xsa-xs-xs&quot;,
                ///   &quot;endpoint&quot;: &quot;http://oss-cn-shanghai.aliyuncs.com&quot;,
                ///   &quot;tag&quot;: &quot;public&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>sqlserver</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;jdbcUrl&quot;: &quot;jdbc:sqlserver://xsaxsa-xsaxsa.database.xxx.cn:123;DatabaseName=xsxs-xsxs&quot;,
                ///   &quot;password&quot;: &quot;sdasda$fs&quot;,
                ///   &quot;tag&quot;: &quot;public&quot;,
                ///   &quot;username&quot;: &quot;sxaxacdacdd&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>polardb</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;clusterId&quot;: &quot;pc-sdadsadsa&quot;,
                ///   &quot;database&quot;: &quot;dsadsadsa&quot;,
                ///   &quot;ownerId&quot;: &quot;121212122&quot;,
                ///   &quot;password&quot;: &quot;sdasdafssa&quot;,
                ///   &quot;region&quot;: &quot;cn-shanghai&quot;,
                ///   &quot;tag&quot;: &quot;polardb&quot;,
                ///   &quot;username&quot;: &quot;asdadsads&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>oracle</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;jdbcUrl&quot;: &quot;jdbc:oracle:saaa:@xxxxx:1521:PROD&quot;,
                ///   &quot;password&quot;: &quot;sxasaxsa&quot;,
                ///   &quot;tag&quot;: &quot;public&quot;,
                ///   &quot;username&quot;: &quot;sasfadfa&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>mongodb</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;address&quot;: &quot;[\\&quot;xsaxxsa.mongodb.rds.aliyuncs.com:3717\\&quot;]&quot;,
                ///   &quot;database&quot;: &quot;admin&quot;,
                ///   &quot;password&quot;: &quot;sadsda@&quot;,
                ///   &quot;tag&quot;: &quot;public&quot;,
                ///   &quot;username&quot;: &quot;dsadsadas&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>emr</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;accessId&quot;: &quot;xsaxsa&quot;,
                ///   &quot;emrClusterId&quot;: &quot;C-dsads&quot;,
                ///   &quot;emrResourceQueueName&quot;: &quot;default&quot;,
                ///   &quot;emrEndpoint&quot;: &quot;emr.aliyuncs.com&quot;,
                ///   &quot;accessKey&quot;: &quot;dsadsad&quot;,
                ///   &quot;emrUserId&quot;: &quot;224833315798889783&quot;,
                ///   &quot;name&quot;: &quot;sasdsadsa&quot;,
                ///   &quot;emrAccessMode&quot;: &quot;simple&quot;,
                ///   &quot;region&quot;: &quot;cn-shanghai&quot;,
                ///   &quot;authType&quot;: &quot;2&quot;,
                ///   &quot;emrProjectId&quot;: &quot;FP-sdadsad&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>postgresql</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;jdbcUrl&quot;: &quot;jdbc:postgresql://xxxx:1921/ssss&quot;,
                ///   &quot;password&quot;: &quot;sdadsads&quot;,
                ///   &quot;tag&quot;: &quot;public&quot;,
                ///   &quot;username&quot;: &quot;sdsasda&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>analyticdb_for_mysql</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;instanceId&quot;: &quot;am-sadsada&quot;,
                ///   &quot;database&quot;: &quot;xsxsx&quot;,
                ///   &quot;username&quot;: &quot;xsxsa&quot;,
                ///   &quot;password&quot;: &quot;asdadsa&quot;,
                ///   &quot;connectionString&quot;: &quot;am-xssxsxs.ads.aliyuncs.com:3306&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>hybriddb_for_postgresql</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;connectionString&quot;: &quot;gp-xsaxsaxa-master.gpdbmaster.rds.aliyuncs.com&quot;,
                ///   &quot;database&quot;: &quot;xsaxsaxas&quot;,
                ///   &quot;password&quot;: &quot;xsaxsaxsa@11&quot;,
                ///   &quot;instanceId&quot;: &quot;gp-xsaxsaxsa&quot;,
                ///   &quot;port&quot;: &quot;541132&quot;,
                ///   &quot;ownerId&quot;: &quot;xsaxsaxsas&quot;,
                ///   &quot;username&quot;: &quot;sadsad&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>holo</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;accessId&quot;: &quot;xsaxsaxs&quot;,
                ///   &quot;accessKey&quot;: &quot;xsaxsaxsa&quot;,
                ///   &quot;database&quot;: &quot;xsaxsaxsa&quot;,
                ///   &quot;instanceId&quot;: &quot;xsaxa&quot;,
                ///   &quot;tag&quot;: &quot;aliyun&quot;
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>kafka</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{
                ///   &quot;instanceId&quot;: &quot;xsax-cn-xsaxsa&quot;,
                ///   &quot;regionId&quot;: &quot;cn-shanghai&quot;,
                ///   &quot;tag&quot;: &quot;aliyun&quot;,
                ///   &quot;ownerId&quot;: &quot;1212121212112&quot;
                /// }
                /// </c></pre>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;database\&quot;:\&quot;xxx\&quot;,\&quot;instanceName\&quot;:\&quot;xxx\&quot;,\&quot;password\&quot;:\&quot;xxx\&quot;,\&quot;rdsOwnerId\&quot;:\&quot;xxx\&quot;,\&quot;tag\&quot;:\&quot;rds\&quot;,\&quot;username\&quot;:\&quot;xxx\&quot;}</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

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
                public int? Id { get; set; }

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
                /// <para>The ID of the workspace with which the data source is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// <para>The field that is used to sort data sources. Data sources are sorted in descending order based on the value of this parameter.</para>
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
                /// <item><description>1: The data source is normal.</description></item>
                /// <item><description>2: The data source is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The subtype of the data source. This parameter is used in scenarios where a type includes subtypes. The following type and subtypes are supported:</para>
                /// <list type="bullet">
                /// <item><description>Type: <c>rds</c></description></item>
                /// <item><description>Subtypes: <c>mysql</c>, <c>sqlserver</c>, and <c>postgresql</c>.</description></item>
                /// </list>
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
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of data sources returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
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

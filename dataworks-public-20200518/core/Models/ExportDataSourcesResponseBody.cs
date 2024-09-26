// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ExportDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the exported data sources.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExportDataSourcesResponseBodyData Data { get; set; }
        public class ExportDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the exported data sources. The value is an array. The following parameters are the elements in the array. The sample values of these parameters show the details of a sample data source.</para>
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<ExportDataSourcesResponseBodyDataDataSources> DataSources { get; set; }
            public class ExportDataSourcesResponseBodyDataDataSources : TeaModel {
                /// <summary>
                /// <para>The ID of the compute engine that is added as the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("BindingCalcEngineId")]
                [Validation(Required=false)]
                public int? BindingCalcEngineId { get; set; }

                /// <summary>
                /// <para>Indicates whether the data source is connected to an exclusive resource group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: The data source is connected to at least one exclusive resource group.</description></item>
                /// <item><description>0: The data source is not connected to any exclusive resource group.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConnectStatus")]
                [Validation(Required=false)]
                public int? ConnectStatus { get; set; }

                /// <summary>
                /// <para>The configuration of the data source.</para>
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
                /// <para>Indicates whether the compute engine that is added as the data source is the default compute engine. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The compute engine is the default compute engine.</description></item>
                /// <item><description>false: The compute engine is not the default compute engine.</description></item>
                /// </list>
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
                /// <para>The environment in which the data source resides. Valid values:</para>
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
                /// <para>The ID of the user who exported the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>193543050****</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace to which the data source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// <para>The sequence number of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

                /// <summary>
                /// <para>Indicates whether the data source can be shared. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The data source can be shared.</description></item>
                /// <item><description>false: The data source cannot be shared.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Shared")]
                [Validation(Required=false)]
                public bool? Shared { get; set; }

                /// <summary>
                /// <para>Indicates whether the data source is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: The data source is available.</description></item>
                /// <item><description>0: The data source is unavailable.</description></item>
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
                /// <para>If the value of the DataSourceType parameter is rds, the value of this parameter can be mysql, sqlserver, or postgresql.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the data source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// <para>The page number. Pages start from page 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>200: The request was successful.</description></item>
        /// <item><description>Other values: The request failed. You can troubleshoot issues based on the HTTP status code returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc14115159376359****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

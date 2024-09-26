// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanQueryListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1029030003</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>param error</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageData")]
        [Validation(Required=false)]
        public DsgDesensPlanQueryListResponseBodyPageData PageData { get; set; }
        public class DsgDesensPlanQueryListResponseBodyPageData : TeaModel {
            /// <summary>
            /// <para>The information about the data masking rule.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DsgDesensPlanQueryListResponseBodyPageDataData> Data { get; set; }
            public class DsgDesensPlanQueryListResponseBodyPageDataData : TeaModel {
                /// <summary>
                /// <para>Indicates whether a watermark is added. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CheckWatermark")]
                [Validation(Required=false)]
                public bool? CheckWatermark { get; set; }

                /// <summary>
                /// <para>The sensitive field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>phone</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The type of the data masking method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HASH</para>
                /// </summary>
                [NameInMap("DesenMode")]
                [Validation(Required=false)]
                public string DesenMode { get; set; }

                /// <summary>
                /// <para>The details of the data masking rule.</para>
                /// </summary>
                [NameInMap("DesensPlan")]
                [Validation(Required=false)]
                public DsgDesensPlanQueryListResponseBodyPageDataDataDesensPlan DesensPlan { get; set; }
                public class DsgDesensPlanQueryListResponseBodyPageDataDataDesensPlan : TeaModel {
                    /// <summary>
                    /// <para>The type of the data masking rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hash</para>
                    /// </summary>
                    [NameInMap("DesensPlanType")]
                    [Validation(Required=false)]
                    public string DesensPlanType { get; set; }

                    /// <summary>
                    /// <para>The parameters for the data masking rule. For more information about the parameters, see the <a href="https://help.aliyun.com/document_detail/2786295.html">DsgDesensPlanAddOrUpdate</a> API reference.</para>
                    /// </summary>
                    [NameInMap("ExtParam")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtParam { get; set; }

                }

                /// <summary>
                /// <para>The data masking rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HASH</para>
                /// </summary>
                [NameInMap("DesensRule")]
                [Validation(Required=false)]
                public string DesensRule { get; set; }

                /// <summary>
                /// <para>The data masking method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HASH</para>
                /// </summary>
                [NameInMap("DesensWay")]
                [Validation(Required=false)]
                public string DesensWay { get; set; }

                /// <summary>
                /// <para>The time when the data masking rule was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-09 15:46:20</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the data masking rule was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-09 15:46:20</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the data masking rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The owner of the data masking rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The name of the data masking rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>phone_hash</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The code of the level-1 data masking scenario to which the rule belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>dataworks_display_desense_code: masking of displayed data in DataStudio and Data Map</description></item>
                /// <item><description>maxcompute_desense_code: data masking at the MaxCompute compute engine layer</description></item>
                /// <item><description>maxcompute_new_desense_code: data masking at the MaxCompute compute engine layer (new)</description></item>
                /// <item><description>hologres_display_desense_code: data masking at the Hologres compute engine layer</description></item>
                /// <item><description>dataworks_data_integration_desense_code: static data masking in Data Integration</description></item>
                /// <item><description>dataworks_analysis_desense_code: masking of displayed data in DataAnalysis</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dataworks_display_desense_code</para>
                /// </summary>
                [NameInMap("SceneCode")]
                [Validation(Required=false)]
                public string SceneCode { get; set; }

                /// <summary>
                /// <para>The name of the level-2 data masking scenario to which the data masking rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_scene</para>
                /// </summary>
                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                /// <summary>
                /// <para>The status of the data masking rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: expired</description></item>
                /// <item><description>1: effective</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

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
            /// <para>The number of entries per page. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The number of data masking rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102400001</para>
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

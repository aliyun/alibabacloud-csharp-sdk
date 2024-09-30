// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetConfigRuleReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic information of the resource non-compliance report that is last generated.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetConfigRuleReportResponseBodyData Data { get; set; }
        public class GetConfigRuleReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the report was generated. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655089159000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crp-ao0786618088006c****</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The ID of the object.</para>
            /// <remarks>
            /// <para> This parameter is returned if you set the <c>TargetType</c> and <c>TargetId</c> parameters in the current request to the same values as the parameters that are configured when you call the <a href="https://help.aliyun.com/document_detail/433313.html">GenerateConfigRuleReport</a> operation to generate the report.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>154950938137****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The type of the object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.</description></item>
            /// <item><description>ROOT: the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
            /// <item><description>FOLDER: a folder other than the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
            /// <item><description>ACCOUNT: a member in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned if you set the <c>TargetType</c> and <c>TargetId</c> parameters in the current request to the same values as the parameters that are configured when you call the <a href="https://help.aliyun.com/document_detail/433313.html">GenerateConfigRuleReport</a> operation to generate the report.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ACCOUNT</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A68BD5BC-5B12-5A9B-8AE9-77884886BE10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateMaliciousFileWhitelistConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateMaliciousFileWhitelistConfigResponseBodyData Data { get; set; }
        public class CreateMaliciousFileWhitelistConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Number of effective assets.</para>
            /// <remarks>
            /// <para>This field has a value when targetType is SELECTION_KEY</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <para>Alert name:</para>
            /// <list type="bullet">
            /// <item><description>ALL: All alert types</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>Whitelisted field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fileMd5</para>
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>Whitelisted field value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b2cf9747ee49d8d9b105cf16e078cc16</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671607025000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671607025000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Rule judgment operator:</para>
            /// <list type="bullet">
            /// <item><description>strEqual: String equals</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>strEqual</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>Business source:</para>
            /// <list type="bullet">
            /// <item><description>agentless: Agentless detection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>agentless</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Effective target type:</para>
            /// <list type="bullet">
            /// <item><description>ALL: All assets</description></item>
            /// <item><description>SELECTION_KEY: Assets selected via the asset selection component</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>Target effective scope:</para>
            /// <list type="bullet">
            /// <item><description>ALL: All assets</description></item>
            /// <item><description>Other: Key of the asset range selected by the asset selection component</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("TargetValue")]
            [Validation(Required=false)]
            public string TargetValue { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Prompt message for the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of this request, which is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-XXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the API call was successful. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Success</description></item>
        /// <item><description><b>false</b>: Failure</description></item>
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

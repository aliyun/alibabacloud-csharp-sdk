// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntElementVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7***B-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public EntElementVerifyResponseBodyResult Result { get; set; }
        public class EntElementVerifyResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Verification result code.</para>
            /// <list type="bullet">
            /// <item><description>1: Verification consistent</description></item>
            /// <item><description>2: Verification inconsistent</description></item>
            /// <item><description>3: Not found</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>Operating period: start and end time of operations.</para>
            /// <list type="bullet">
            /// <item><description>Format: yyyy-MM-dd/yyyy-MM-dd.</description></item>
            /// <item><description>Example: 2018-09-25/9999-09-09.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-25/9999-09-09</para>
            /// </summary>
            [NameInMap("OpenTime")]
            [Validation(Required=false)]
            public string OpenTime { get; set; }

            /// <summary>
            /// <para>ReasonCode explanation:</para>
            /// <list type="bullet">
            /// <item><description><para>100: Verification consistent</para>
            /// </description></item>
            /// <item><description><para>201: Inconsistent between person and enterprise</para>
            /// </description></item>
            /// <item><description><para>202: Inconsistent in two elements of the enterprise</para>
            /// </description></item>
            /// <item><description><para>301: No enterprise found, unable to verify</para>
            /// </description></item>
            /// <item><description><para>302: Legal representative does not exist in the database</para>
            /// <remarks>
            /// <para>Warning: This field will be discontinued on June 15, 2023. Existing customers are not affected.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>Details of inconsistencies, multiple inconsistencies will be separated by commas.</para>
            /// <list type="bullet">
            /// <item><description>LegalPersonNameFlag: Inconsistent legal representative name</description></item>
            /// <item><description>LegalPersonCertNoFlag: Inconsistent legal representative ID number</description></item>
            /// <item><description>EntNameFlag: Inconsistent enterprise name</description></item>
            /// <item><description>LicenseNoFlag: Inconsistent business license number</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LegalPersonNameFlag,LegalPersonCertNoFlag</para>
            /// </summary>
            [NameInMap("ReasonDetail")]
            [Validation(Required=false)]
            public string ReasonDetail { get; set; }

            /// <summary>
            /// <para>Enterprise operating status.</para>
            /// <list type="bullet">
            /// <item><description>1: In operation (open)</description></item>
            /// <item><description>2: Relocated</description></item>
            /// <item><description>3: Deregistered</description></item>
            /// <item><description>4: Revoked</description></item>
            /// <item><description>5: Canceled</description></item>
            /// <item><description>6: Suspended</description></item>
            /// <item><description>0: Other</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}

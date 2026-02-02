// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntElementVerifyV2ResponseBody : TeaModel {
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
        /// <para>Id of the request</para>
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
        public EntElementVerifyV2ResponseBodyResult Result { get; set; }
        public class EntElementVerifyV2ResponseBodyResult : TeaModel {
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
            /// <para>Business term: start and end time of operations.</para>
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
            /// <para>Details of inconsistencies, multiple inconsistencies will be separated by commas.</para>
            /// <list type="bullet">
            /// <item><description>LegalPersonNameFlag: Legal person\&quot;s name does not match</description></item>
            /// <item><description>LegalPersonCertNoFlag: Legal person\&quot;s ID number does not match</description></item>
            /// <item><description>EntNameFlag: Enterprise name does not match</description></item>
            /// <item><description>LicenseNoFlag: Business license number does not match</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LegalPersonNameFlag,LegalPersonCertNoFlag</para>
            /// </summary>
            [NameInMap("ReasonDetail")]
            [Validation(Required=false)]
            public string ReasonDetail { get; set; }

            /// <summary>
            /// <para>Business operation status.</para>
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

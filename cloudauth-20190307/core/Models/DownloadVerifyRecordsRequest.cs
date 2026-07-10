// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DownloadVerifyRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions in JSON string format. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><b>DownloadMode (String)</b>: the download mode.<list type="bullet">
        /// <item><description>Example: sync</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>InvokeType (String)</b>: the product plan, which corresponds to <b>ProductType</b>.</description></item>
        /// <item><description><b>SceneIdList (List<Long>)</b>: the list of scene IDs.</description></item>
        /// <item><description><b>StatisticsType (String)</b>: the statistics type. Valid values:<list type="bullet">
        /// <item><description>day</description></item>
        /// <item><description>month</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>StartDate (String)</b>: the query start time.<list type="bullet">
        /// <item><description>Example: 2025-09-17 00:00:00 +0800</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>EndDate (String)</b>: the query end time.<list type="bullet">
        /// <item><description>Example: 2025-10-16 23:59:59 +0800</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>ProductProgramList</b>: the list of product codes under the product plan to query.<list type="bullet">
        /// <item><description>Example: [&quot;FINANCE_FACE_VERIFY&quot;,&quot;MFVC&quot;]</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Code (information verification API)</b>: Valid values:<list type="bullet">
        /// <item><description><b>ID_CARD_2_META</b>: ID card two-factor verification</description></item>
        /// <item><description><b>ID_PERIOD</b>: ID card validity period verification</description></item>
        /// <item><description><b>MOBILE_ONLINE_LENGTH</b>: mobile number online duration</description></item>
        /// <item><description><b>MOBILE_ONLINE_STATUS</b>: mobile number online status</description></item>
        /// <item><description><b>MOBILE_3_META_SIMPLE</b>: mobile number three-factor verification (basic)</description></item>
        /// <item><description><b>MOBILE_3_META</b>: mobile number three-factor verification (detailed)</description></item>
        /// <item><description><b>MOBILE_2_META</b>: mobile number two-factor verification</description></item>
        /// <item><description><b>BANK_CARD_N_META</b>: bank card verification (detailed)</description></item>
        /// <item><description><b>MOBILE_DETECT</b>: phone number detection </description></item>
        /// <item><description><b>VEHICLE_N_META</b>: vehicle element verification (enhanced)</description></item>
        /// <item><description><b>VEHICLE_PENTA_INFO</b>: vehicle five-element information recognition</description></item>
        /// <item><description><b>VEHICLE_LICENSE_INFO</b>: vehicle information recognition</description></item>
        /// <item><description><b>VEHICLE_INSURE_DATE</b>: vehicle insurance date query</description></item>
        /// <item><description><b>VEHICLE_CHECK</b>: vehicle element verification</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>ProductCode (information verification)</b>: same as Code.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProductType&quot;:&quot;INVOKE_STATISTICS&quot;,&quot;BizParam&quot;:{&quot;DownloadMode&quot;:&quot;sync&quot;,&quot;InvokeType&quot;:&quot;FINANCE_VERIFY&quot;,&quot;SceneIdList&quot;:&quot;[]&quot;,&quot;ProductProgramList&quot;:&quot;[\&quot;FINANCE_FACE_VERIFY\&quot;,\&quot;MFVC\&quot;,\&quot;PV_FV\&quot;,\&quot;CLOUD_FACE_CAPTURE\&quot;,\&quot;FACE_GUARD\&quot;,\&quot;PV_FC\&quot;]&quot;,&quot;StatisticsType&quot;:&quot;day&quot;,&quot;StartDate&quot;:&quot;2025-09-17 00:00:00 +0800&quot;,&quot;EndDate&quot;:&quot;2025-10-16 23:59:59 +0800&quot;}}</para>
        /// </summary>
        [NameInMap("BizParam")]
        [Validation(Required=false)]
        public string BizParam { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FINANCE_VERIFY</b>: financial-grade ID Verification</description></item>
        /// <item><description><b>SMART_VERIFY</b>: enhanced ID Verification (discontinued)</description></item>
        /// <item><description><b>FACE_VERIFY</b>: ID Verification (discontinued)</description></item>
        /// <item><description><b>INFO_CHECK_STATISTICS</b>: information verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FINANCE_VERIFY</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}

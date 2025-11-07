// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DownloadVerifyRecordsRequest : TeaModel {
        /// <summary>
        /// <para>Query condition in JSON string format, specifically including fields:</para>
        /// <list type="bullet">
        /// <item><description><b>DownloadMode (String)</b>: Download mode,<list type="bullet">
        /// <item><description>Example value: sync</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>InvokeType (String)</b>: Product plan, corresponding to <b>ProductType</b></description></item>
        /// <item><description><b>SceneIdList (List<Long>)</b>: List of scene IDs</description></item>
        /// <item><description><b>StatisticsType (String)</b>: Statistics type<list type="bullet">
        /// <item><description>day</description></item>
        /// <item><description>month</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>StartDate (String)</b>: Start date of the query<list type="bullet">
        /// <item><description>Example value: 2025-09-17 00:00:00 +0800</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>EndDate (String)</b>: End date of the query<list type="bullet">
        /// <item><description>Example value: 2025-10-16 23:59:59 +0800</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>ProductProgramList</b>: List of product codes under the queried product plan<list type="bullet">
        /// <item><description>Example value: [&quot;FINANCE_FACE_VERIFY&quot;,&quot;MFVC&quot;]</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Code (Information Verification API)</b>:<list type="bullet">
        /// <item><description><b>ID_CARD_2_META</b>: ID card two-factor verification</description></item>
        /// <item><description><b>ID_PERIOD</b>: Validity period of ID card verification</description></item>
        /// <item><description><b>MOBILE_ONLINE_LENGTH</b>: Mobile online duration</description></item>
        /// <item><description><b>MOBILE_ONLINE_STATUS</b>: Mobile online status</description></item>
        /// <item><description><b>MOBILE_3_META_SIMPLE</b>: Simplified mobile three-factor verification</description></item>
        /// <item><description><b>MOBILE_3_META</b>: Detailed mobile three-factor verification</description></item>
        /// <item><description><b>MOBILE_2_META</b>: Mobile two-factor verification</description></item>
        /// <item><description><b>BANK_CARD_N_META</b>: Detailed bank card verification</description></item>
        /// <item><description><b>MOBILE_DETECT</b>: Number detection </description></item>
        /// <item><description><b>VEHICLE_N_META</b>: Enhanced vehicle factor verification</description></item>
        /// <item><description><b>VEHICLE_PENTA_INFO</b>: Vehicle five-item information recognition</description></item>
        /// <item><description><b>VEHICLE_LICENSE_INFO</b>: Vehicle information recognition</description></item>
        /// <item><description><b>VEHICLE_INSURE_DATE</b>: Vehicle insurance date inquiry</description></item>
        /// <item><description><b>VEHICLE_CHECK</b>: Vehicle factor verification</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>ProductCode</b> (Information Verification): Same as Code</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProductType&quot;:&quot;INVOKE_STATISTICS&quot;,&quot;BizParam&quot;:{&quot;DownloadMode&quot;:&quot;sync&quot;,&quot;InvokeType&quot;:&quot;FINANCE_VERIFY&quot;,&quot;SceneIdList&quot;:&quot;[]&quot;,&quot;ProductProgramList&quot;:&quot;[\&quot;FINANCE_FACE_VERIFY\&quot;,\&quot;MFVC\&quot;,\&quot;PV_FV\&quot;,\&quot;CLOUD_FACE_CAPTURE\&quot;,\&quot;FACE_GUARD\&quot;,\&quot;PV_FC\&quot;]&quot;,&quot;StatisticsType&quot;:&quot;day&quot;,&quot;StartDate&quot;:&quot;2025-09-17 00:00:00 +0800&quot;,&quot;EndDate&quot;:&quot;2025-10-16 23:59:59 +0800&quot;}}</para>
        /// </summary>
        [NameInMap("BizParam")]
        [Validation(Required=false)]
        public string BizParam { get; set; }

        /// <summary>
        /// <para>Product type:</para>
        /// <list type="bullet">
        /// <item><description><b>FINANCE_VERIFY</b>: Financial-level real-person authentication</description></item>
        /// <item><description><b>SMART_VERIFY</b>: Enhanced real-person authentication (discontinued)</description></item>
        /// <item><description><b>FACE_VERIFY</b>: Real-person authentication (discontinued)</description></item>
        /// <item><description><b>INFO_CHECK_STATISTICS</b>: Information verification</description></item>
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

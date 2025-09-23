// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20210112.Models
{
    public class UploadSampleApiRequest : TeaModel {
        /// <summary>
        /// <para>The data type of the sample</para>
        /// <list type="bullet">
        /// <item><description>Phone number: mobile</description></item>
        /// <item><description>MD5 of phone number: mobileMd5</description></item>
        /// <item><description>IP: ip</description></item>
        /// <item><description>Unique device ID: umid</description></item>
        /// <item><description>Account ID: accountId</description></item>
        /// <item><description>IMEI: imei</description></item>
        /// <item><description>MD5 of IMEI: imeiMd5</description></item>
        /// <item><description>OAID: oaid</description></item>
        /// <item><description>MD5 of OAID: oaidMd5</description></item>
        /// <item><description>Android ID: androidId</description></item>
        /// <item><description>MD5 of Android ID: androidIdMd5</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Specific value of the sample, to be passed in JSON format. Do not exceed 1000 entries at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;123.124.125.126&quot;,&quot;123.124.125.127&quot;]</para>
        /// </summary>
        [NameInMap("DataValue")]
        [Validation(Required=false)]
        public string DataValue { get; set; }

        /// <summary>
        /// <para>The type of the sample</para>
        /// <list type="bullet">
        /// <item><description><para>Blacklist: block</para>
        /// </description></item>
        /// <item><description><para>Whitelist: pass</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>block</para>
        /// </summary>
        [NameInMap("SampleType")]
        [Validation(Required=false)]
        public string SampleType { get; set; }

        /// <summary>
        /// <para>List of effective services, separate multiple services with commas</para>
        /// <list type="bullet">
        /// <item><description>Basic/Enhanced Registration Risk Identification: account_abuse</description></item>
        /// <item><description>Basic/Enhanced Marketing Risk Identification: coupon_abuse</description></item>
        /// <item><description>Basic/Enhanced Login Risk Identification: account_takeover</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account_abuse,coupon_abuse,account_takeover</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyFailStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>Age greater than 14 years old:</para>
        /// <list type="bullet">
        /// <item><description><b>T</b>: Greater than</description></item>
        /// <item><description><b>F</b>: Less than</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("AgeGt")]
        [Validation(Required=false)]
        public string AgeGt { get; set; }

        /// <summary>
        /// <para>API code:</para>
        /// <list type="bullet">
        /// <item><description><b>INIT_SERVICE</b>: Server-side initialization failure</description></item>
        /// <item><description><b>INIT_DEVICE</b>: Client-side failure</description></item>
        /// <item><description><b>VERIFY_DEVICE</b>: Authentication failed</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INIT_SERVICE</para>
        /// </summary>
        [NameInMap("Api")]
        [Validation(Required=false)]
        public string Api { get; set; }

        /// <summary>
        /// <para>Device type.</para>
        /// <list type="bullet">
        /// <item><description>ios</description></item>
        /// <item><description>android</description></item>
        /// <item><description>websdk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ios</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>End time of the query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760630399999</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>Product code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Service type:</para>
        /// <list type="bullet">
        /// <item><description><b>antcloudauth</b>: Financial-grade real-person authentication.</description></item>
        /// <item><description><b>cloudauthst</b> (discontinued): Enhanced real-person authentication.</description></item>
        /// <item><description><b>cloudauth</b> (discontinued): Real-person authentication.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudauthst</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>Start time of the query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760025600000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}

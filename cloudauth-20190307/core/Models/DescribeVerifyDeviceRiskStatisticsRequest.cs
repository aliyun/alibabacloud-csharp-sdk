// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyDeviceRiskStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>End time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748624399999</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>Cloud product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000xxxx</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

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
        /// <para>antcloudauth</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>Start time of the query, in Unix timestamp format, in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1746720000000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}

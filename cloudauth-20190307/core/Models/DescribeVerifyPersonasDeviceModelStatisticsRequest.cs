// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyPersonasDeviceModelStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>Product Code.</para>
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
        /// <para>1000015316</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>Service type:</para>
        /// <list type="bullet">
        /// <item><description><b>antcloudauth</b>: Financial-grade real-person authentication.</description></item>
        /// <item><description><b>cloudauthst</b> (discontinued): Enhanced real-person authentication.</description></item>
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
        /// <para>Time range for the query, indicating how many days back.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}

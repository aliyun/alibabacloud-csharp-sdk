// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateIpcOrderRequest : TeaModel {
        /// <summary>
        /// <para>The capability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>understand: Image understanding. Supports the analysis of 300 images per day.</para>
        /// </description></item>
        /// <item><description><para>understand-reid: Image understanding with person re-identification (ReID). Supports the analysis of 300 images per day.</para>
        /// </description></item>
        /// <item><description><para>search: Search. Supports 75 searches per day.</para>
        /// </description></item>
        /// <item><description><para>understand-search: Image understanding and search. Supports the analysis of 300 images and 75 searches per day.</para>
        /// </description></item>
        /// <item><description><para>understand-reid-search: Image understanding with ReID and search. Supports the analysis of 300 images and 75 searches per day.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>understand</para>
        /// </summary>
        [NameInMap("Capability")]
        [Validation(Required=false)]
        public string Capability { get; set; }

        /// <summary>
        /// <para>The device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d123</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>The subscription period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>month: A monthly subscription, calculated as 30 days.</para>
        /// </description></item>
        /// <item><description><para>quarter: A quarterly subscription, calculated as 90 days.</para>
        /// </description></item>
        /// <item><description><para>year: An annual subscription, calculated as 365 days.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

    }

}

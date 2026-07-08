// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class RenewRenderingInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Enable or disable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The duration of the subscription. Valid values are 1 (default), 2, 3, 4, 5, 6, 7, 8, 9, 12. A value of 12 is converted to one year; other values are in months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>Cloud application service instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpgradeRenderingInstanceImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of failed instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public long? FailedCount { get; set; }

        /// <summary>
        /// <para>The information about the failed instances.</para>
        /// </summary>
        [NameInMap("FailedItems")]
        [Validation(Required=false)]
        public List<UpgradeRenderingInstanceImageResponseBodyFailedItems> FailedItems { get; set; }
        public class UpgradeRenderingInstanceImageResponseBodyFailedItems : TeaModel {
            /// <summary>
            /// <para>The error code for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200302</para>
            /// </summary>
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }

            /// <summary>
            /// <para>The error message for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not Applied</para>
            /// </summary>
            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

            /// <summary>
            /// <para>The cloud application service instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-072da95539d3402da90353b244191722</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of successfully upgraded instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public long? SuccessCount { get; set; }

        /// <summary>
        /// <para>The information about the successfully upgraded instances.</para>
        /// </summary>
        [NameInMap("SuccessItems")]
        [Validation(Required=false)]
        public List<UpgradeRenderingInstanceImageResponseBodySuccessItems> SuccessItems { get; set; }
        public class UpgradeRenderingInstanceImageResponseBodySuccessItems : TeaModel {
            /// <summary>
            /// <para>The cloud application service instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-1ada8cd82783407b99fa202826fc6447</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

    }

}

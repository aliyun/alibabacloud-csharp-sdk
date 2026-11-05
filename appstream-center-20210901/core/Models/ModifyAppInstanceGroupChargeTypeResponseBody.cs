// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppInstanceGroupChargeTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The task information for the billing method conversion.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupModel")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupChargeTypeResponseBodyAppInstanceGroupModel AppInstanceGroupModel { get; set; }
        public class ModifyAppInstanceGroupChargeTypeResponseBodyAppInstanceGroupModel : TeaModel {
            /// <summary>
            /// <para>The ID of the billing conversion order task, used to associate with the current conversion. It is returned only when a related order task is required and created. It does not indicate that the payment is completed or the new billing method has taken effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request. You can use the ID to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

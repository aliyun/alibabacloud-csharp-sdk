// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ScaleK8sApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Call the <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a> operation to obtain the application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23bf94d9-<b><b>-4994-</b></b>-616a827aa777</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The target number of application instances. The minimum value is 0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The timeout period for the change process, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}

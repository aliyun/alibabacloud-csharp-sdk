// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class ModifyCallbackMetaRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223***JQb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The callback configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public ModifyCallbackMetaRequestCallback Callback { get; set; }
        public class ModifyCallbackMetaRequestCallback : TeaModel {
            /// <summary>
            /// <para>The callback code.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RecordEvent</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Conf")]
            [Validation(Required=false)]
            public string Conf { get; set; }

            /// <summary>
            /// <para>The sub-events.
            /// Recording events:</para>
            /// <list type="bullet">
            /// <item><description><b>2010</b>: Recording service status change.</description></item>
            /// <item><description><b>2011</b>: Recording audio stream status change.</description></item>
            /// <item><description><b>2012</b>: Recording video stream status change.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SubEvent")]
            [Validation(Required=false)]
            public List<int?> SubEvent { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}

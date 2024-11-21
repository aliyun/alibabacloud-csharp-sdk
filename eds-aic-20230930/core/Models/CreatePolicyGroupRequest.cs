// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreatePolicyGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>readwrite</para>
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Html5FileTransfer")]
        [Validation(Required=false)]
        public string Html5FileTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        [NameInMap("LockResolution")]
        [Validation(Required=false)]
        public string LockResolution { get; set; }

        [NameInMap("NetRedirectPolicy")]
        [Validation(Required=false)]
        public CreatePolicyGroupRequestNetRedirectPolicy NetRedirectPolicy { get; set; }
        public class CreatePolicyGroupRequestNetRedirectPolicy : TeaModel {
            [NameInMap("CustomProxy")]
            [Validation(Required=false)]
            public string CustomProxy { get; set; }

            [NameInMap("HostAddr")]
            [Validation(Required=false)]
            public string HostAddr { get; set; }

            [NameInMap("NetRedirect")]
            [Validation(Required=false)]
            public string NetRedirect { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("ProxyPassword")]
            [Validation(Required=false)]
            public string ProxyPassword { get; set; }

            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

            [NameInMap("ProxyUserName")]
            [Validation(Required=false)]
            public string ProxyUserName { get; set; }

        }

        [NameInMap("PolicyGroupName")]
        [Validation(Required=false)]
        public string PolicyGroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("ResolutionWidth")]
        [Validation(Required=false)]
        public int? ResolutionWidth { get; set; }

    }

}

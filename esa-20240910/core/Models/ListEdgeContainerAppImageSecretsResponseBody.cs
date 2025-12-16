// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEdgeContainerAppImageSecretsResponseBody : TeaModel {
        [NameInMap("ImageSecretList")]
        [Validation(Required=false)]
        public List<ListEdgeContainerAppImageSecretsResponseBodyImageSecretList> ImageSecretList { get; set; }
        public class ListEdgeContainerAppImageSecretsResponseBodyImageSecretList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>reg-123****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Registry")]
            [Validation(Required=false)]
            public string Registry { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3558df77-8a7a-4060-a900-2d7949403836</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

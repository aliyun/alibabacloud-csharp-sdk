// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ListPolicyGroupsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uON****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PolicyGroupModel")]
        [Validation(Required=false)]
        public List<ListPolicyGroupsResponseBodyPolicyGroupModel> PolicyGroupModel { get; set; }
        public class ListPolicyGroupsResponseBodyPolicyGroupModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
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
            /// <para>2024-06-04 10:28:54</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>download</para>
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
            public ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicy NetRedirectPolicy { get; set; }
            public class ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicy : TeaModel {
                [NameInMap("NetRedirect")]
                [Validation(Required=false)]
                public string NetRedirect { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pg-9q6o8qpiy8opkj****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public string SessionResolutionHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public string SessionResolutionWidth { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7B9EFA4F-4305-5968-BAEE-BD8B8DE5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ListPolicyGroupsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PolicyGroupModel")]
        [Validation(Required=false)]
        public List<ListPolicyGroupsResponseBodyPolicyGroupModel> PolicyGroupModel { get; set; }
        public class ListPolicyGroupsResponseBodyPolicyGroupModel : TeaModel {
            [NameInMap("CameraRedirect")]
            [Validation(Required=false)]
            public string CameraRedirect { get; set; }

            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            [NameInMap("NetRedirectPolicy")]
            [Validation(Required=false)]
            public ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicy NetRedirectPolicy { get; set; }
            public class ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicy : TeaModel {
                [NameInMap("NetRedirect")]
                [Validation(Required=false)]
                public string NetRedirect { get; set; }

            }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public string SessionResolutionHeight { get; set; }

            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public string SessionResolutionWidth { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

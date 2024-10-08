// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class UpdateDeviceBindedEndUserRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        [NameInMap("SourceAdEndUsers")]
        [Validation(Required=false)]
        public List<UpdateDeviceBindedEndUserRequestSourceAdEndUsers> SourceAdEndUsers { get; set; }
        public class UpdateDeviceBindedEndUserRequestSourceAdEndUsers : TeaModel {
            [NameInMap("AdDomain")]
            [Validation(Required=false)]
            public string AdDomain { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

        }

        [NameInMap("SourceEndUserIds")]
        [Validation(Required=false)]
        public string SourceEndUserIds { get; set; }

        [NameInMap("TargetAdEndUsers")]
        [Validation(Required=false)]
        public List<UpdateDeviceBindedEndUserRequestTargetAdEndUsers> TargetAdEndUsers { get; set; }
        public class UpdateDeviceBindedEndUserRequestTargetAdEndUsers : TeaModel {
            [NameInMap("AdDomain")]
            [Validation(Required=false)]
            public string AdDomain { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

        }

        [NameInMap("TargetEndUserIds")]
        [Validation(Required=false)]
        public string TargetEndUserIds { get; set; }

        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}

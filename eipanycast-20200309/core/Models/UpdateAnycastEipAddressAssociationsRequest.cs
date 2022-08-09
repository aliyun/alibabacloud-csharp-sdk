// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class UpdateAnycastEipAddressAssociationsRequest : TeaModel {
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        [NameInMap("AssociationMode")]
        [Validation(Required=false)]
        public string AssociationMode { get; set; }

        [NameInMap("BindInstanceId")]
        [Validation(Required=false)]
        public string BindInstanceId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("PopLocationAddList")]
        [Validation(Required=false)]
        public List<UpdateAnycastEipAddressAssociationsRequestPopLocationAddList> PopLocationAddList { get; set; }
        public class UpdateAnycastEipAddressAssociationsRequestPopLocationAddList : TeaModel {
            [NameInMap("PopLocation")]
            [Validation(Required=false)]
            public string PopLocation { get; set; }

        }

        [NameInMap("PopLocationDeleteList")]
        [Validation(Required=false)]
        public List<UpdateAnycastEipAddressAssociationsRequestPopLocationDeleteList> PopLocationDeleteList { get; set; }
        public class UpdateAnycastEipAddressAssociationsRequestPopLocationDeleteList : TeaModel {
            [NameInMap("PopLocation")]
            [Validation(Required=false)]
            public string PopLocation { get; set; }

        }

    }

}

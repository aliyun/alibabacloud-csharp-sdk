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

        /// <summary>
        /// 关联模式，默认模式、普通模式Default/Normal
        /// </summary>
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

        /// <summary>
        /// 新增关联的pop location
        /// </summary>
        [NameInMap("PopLocationAddList")]
        [Validation(Required=false)]
        public List<UpdateAnycastEipAddressAssociationsRequestPopLocationAddList> PopLocationAddList { get; set; }
        public class UpdateAnycastEipAddressAssociationsRequestPopLocationAddList : TeaModel {
            /// <summary>
            /// pop location
            /// </summary>
            [NameInMap("PopLocation")]
            [Validation(Required=false)]
            public string PopLocation { get; set; }

        }

        /// <summary>
        /// 待删除的关联pop location
        /// </summary>
        [NameInMap("PopLocationDeleteList")]
        [Validation(Required=false)]
        public List<UpdateAnycastEipAddressAssociationsRequestPopLocationDeleteList> PopLocationDeleteList { get; set; }
        public class UpdateAnycastEipAddressAssociationsRequestPopLocationDeleteList : TeaModel {
            /// <summary>
            /// pop location
            /// </summary>
            [NameInMap("PopLocation")]
            [Validation(Required=false)]
            public string PopLocation { get; set; }

        }

    }

}

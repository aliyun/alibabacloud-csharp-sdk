// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class CreateDiagnoseRequest : TeaModel {
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        [NameInMap("DiagnoseAction")]
        [Validation(Required=false)]
        public string DiagnoseAction { get; set; }

        [NameInMap("DiagnoseErrorCode")]
        [Validation(Required=false)]
        public string DiagnoseErrorCode { get; set; }

        [NameInMap("DiagnoseProduct")]
        [Validation(Required=false)]
        public string DiagnoseProduct { get; set; }

        [NameInMap("DiagnoseRequestId")]
        [Validation(Required=false)]
        public string DiagnoseRequestId { get; set; }

        [NameInMap("DiagnoseRequestParams")]
        [Validation(Required=false)]
        public string DiagnoseRequestParams { get; set; }

        [NameInMap("DiagnoseResponse")]
        [Validation(Required=false)]
        public string DiagnoseResponse { get; set; }

        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("InstanceTypeName")]
        [Validation(Required=false)]
        public string InstanceTypeName { get; set; }

        [NameInMap("IzNo")]
        [Validation(Required=false)]
        public string IzNo { get; set; }

        [NameInMap("Mark")]
        [Validation(Required=false)]
        public string Mark { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiagnoseRequestTag> Tag { get; set; }
        public class CreateDiagnoseRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}

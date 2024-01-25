// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20211130.Models
{
    public class CreateComputeTaskByDataSetIdRequest : TeaModel {
        [NameInMap("BatchInfoForm")]
        [Validation(Required=false)]
        public List<CreateComputeTaskByDataSetIdRequestBatchInfoForm> BatchInfoForm { get; set; }
        public class CreateComputeTaskByDataSetIdRequestBatchInfoForm : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("CuVersions")]
            [Validation(Required=false)]
            public List<CreateComputeTaskByDataSetIdRequestBatchInfoFormCuVersions> CuVersions { get; set; }
            public class CreateComputeTaskByDataSetIdRequestBatchInfoFormCuVersions : TeaModel {
                [NameInMap("CuId")]
                [Validation(Required=false)]
                public string CuId { get; set; }

                [NameInMap("CuVersion")]
                [Validation(Required=false)]
                public string CuVersion { get; set; }

            }

        }

        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

    }

}

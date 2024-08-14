// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListInstancesShrinkRequest : TeaModel {
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("GpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string LabelsShrink { get; set; }

        [NameInMap("MaxCpu")]
        [Validation(Required=false)]
        public string MaxCpu { get; set; }

        [NameInMap("MaxGpu")]
        [Validation(Required=false)]
        public string MaxGpu { get; set; }

        [NameInMap("MaxGpuMemory")]
        [Validation(Required=false)]
        public string MaxGpuMemory { get; set; }

        [NameInMap("MaxMemory")]
        [Validation(Required=false)]
        public string MaxMemory { get; set; }

        [NameInMap("MinCpu")]
        [Validation(Required=false)]
        public string MinCpu { get; set; }

        [NameInMap("MinGpu")]
        [Validation(Required=false)]
        public string MinGpu { get; set; }

        [NameInMap("MinGpuMemory")]
        [Validation(Required=false)]
        public string MinGpuMemory { get; set; }

        [NameInMap("MinMemory")]
        [Validation(Required=false)]
        public string MinMemory { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

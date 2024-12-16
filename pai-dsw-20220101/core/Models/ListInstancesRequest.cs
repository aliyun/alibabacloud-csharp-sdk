// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AcceleratorType</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>dsw-730xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>training_data</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-123456789</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gmtCreate</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListInstancesRequestTag> Tag { get; set; }
        public class ListInstancesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40823</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

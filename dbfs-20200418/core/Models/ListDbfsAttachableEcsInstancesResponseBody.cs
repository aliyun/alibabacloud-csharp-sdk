// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListDbfsAttachableEcsInstancesResponseBody : TeaModel {
        [NameInMap("EcsLabelInfo")]
        [Validation(Required=false)]
        public List<ListDbfsAttachableEcsInstancesResponseBodyEcsLabelInfo> EcsLabelInfo { get; set; }
        public class ListDbfsAttachableEcsInstancesResponseBodyEcsLabelInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>m-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs.g7se</para>
            /// </summary>
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Linux 2.1903 LTS 64 bit</para>
            /// </summary>
            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbfs-test-01</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-bp10jb8mqajkmrejgo00</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3724CFEF-02DA-578B-AED6-67EE80671B4A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

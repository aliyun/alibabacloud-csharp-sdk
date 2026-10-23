// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAgenticDBBranchResponseBody : TeaModel {
        /// <summary>
        /// <para>The branch compute cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-g0lsayq8c5qe</para>
        /// </summary>
        [NameInMap("BranchComputeClusterId")]
        [Validation(Required=false)]
        public string BranchComputeClusterId { get; set; }

        /// <summary>
        /// <para>The branch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-7g8h9i0j1k2l</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public string BranchId { get; set; }

        /// <summary>
        /// <para>The name of the branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature-analytics</para>
        /// </summary>
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <para>The AgenticDB cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pagc-bp1abcdef1234567</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The parent branch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-1a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("ParentBranchId")]
        [Validation(Required=false)]
        public string ParentBranchId { get; set; }

        /// <summary>
        /// <para>The name of the parent branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("ParentBranchName")]
        [Validation(Required=false)]
        public string ParentBranchName { get; set; }

        /// <summary>
        /// <para>The historical timestamp of the parent branch specified when the branch was created. The value is in UTC RFC 3339 format. This field may be empty if no historical timestamp was specified or for legacy records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-15T07:32:00.123456Z</para>
        /// </summary>
        [NameInMap("ParentTimestamp")]
        [Validation(Required=false)]
        public string ParentTimestamp { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proj-a1b2c3d4e5f6</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analytics-prod</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-1234567890AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

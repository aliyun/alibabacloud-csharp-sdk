// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class UpdateSkillResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The skill ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill_example123</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Returns <c>true</c> if the skill update and optional package replacement have been fully submitted and confirmed by read-back.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The time when the skill was updated. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760000200000</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ImportRamUsersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;28036411123456****&quot;,&quot;29234301123456****&quot;]</para>
        /// </summary>
        [NameInMap("RamIdList")]
        [Validation(Required=false)]
        public string RamIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent@ccc-test</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;skillGroupId&quot;:&quot;skillgroup@ccc-test&quot;,&quot;skillLevel&quot;:5}]</para>
        /// </summary>
        [NameInMap("SkillLevelList")]
        [Validation(Required=false)]
        public string SkillLevelList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON_SITE</para>
        /// </summary>
        [NameInMap("WorkMode")]
        [Validation(Required=false)]
        public string WorkMode { get; set; }

    }

}

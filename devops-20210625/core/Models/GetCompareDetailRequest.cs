// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetCompareDetailRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9fb781f3d66ef6ee60bdd5c414f5106454b1426</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24 * 1024 * 1024</para>
        /// </summary>
        [NameInMap("maxDiffByte")]
        [Validation(Required=false)]
        public int? MaxDiffByte { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("maxDiffFile")]
        [Validation(Required=false)]
        public int? MaxDiffFile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("mergeBase")]
        [Validation(Required=false)]
        public bool? MergeBase { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ebbc0228123212b59xxxxx</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b8f6f28520b1936aafe2e638373e19ccafa42b02</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}

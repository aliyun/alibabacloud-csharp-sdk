// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class AddKeywordLibRequest : TeaModel {
        /// <summary>
        /// <para>The keywords. Separate multiple keywords with 
        /// .</para>
        /// 
        /// <b>Example:</b>
        /// <para>keyword1\nkeyword2</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>The name of the keyword file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upload/1e5353c0-0d91-40ba-9d41-ae7abd3fe561.txt</para>
        /// </summary>
        [NameInMap("KeywordsObject")]
        [Validation(Required=false)]
        public string KeywordsObject { get; set; }

        /// <summary>
        /// <para>The name of the keyword library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestLibrary.</para>
        /// </summary>
        [NameInMap("LibName")]
        [Validation(Required=false)]
        public string LibName { get; set; }

        /// <summary>
        /// <para>The properties.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;attribute&quot;:&quot;xx&quot;}</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The library code.</para>
        /// <list type="bullet">
        /// <item><description>desensitize: desensitization library</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desensitize</para>
        /// </summary>
        [NameInMap("TenantCode")]
        [Validation(Required=false)]
        public string TenantCode { get; set; }

    }

}

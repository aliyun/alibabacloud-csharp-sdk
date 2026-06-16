// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleResultsValue : TeaModel {
        /// <summary>
        /// <para>是否通过检查</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Passed")]
        [Validation(Required=false)]
        public bool? Passed { get; set; }

        /// <summary>
        /// <para>资源标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>InspirationTokens</para>
        /// </summary>
        [NameInMap("ResourceCode")]
        [Validation(Required=false)]
        public string ResourceCode { get; set; }

        /// <summary>
        /// <para>失败时的错误码，通过时为null</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource.Control.No.Usage</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>失败时的错误信息，通过时为null</para>
        /// 
        /// <b>Example:</b>
        /// <para>用量耗尽</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

    }

}

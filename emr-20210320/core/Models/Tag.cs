// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Tag : TeaModel {
        /// <summary>
        /// <para>标签键。必填参数，不允许为空字符串。最多支持128个字符，不能以aliyun和acs:开头，不能包含http://或https://。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>department</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>标签值。非必填，可以为空字符串。最多支持128个字符，不能以acs:开头，不能包含http://或者https://。</para>
        /// 
        /// <b>Example:</b>
        /// <para>IT</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}

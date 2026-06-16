// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CheckTaskGroupNameRequest : TeaModel {
        /// <summary>
        /// <para>Language of error messages returned by the API. Valid values: zh: Chinese, en: English. Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Area encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Task group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GroupNameTest</para>
        /// </summary>
        [NameInMap("TaskGroupName")]
        [Validation(Required=false)]
        public string TaskGroupName { get; set; }

    }

}

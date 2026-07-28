// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class JobStatusDetailValue : TeaModel {
        /// <summary>
        /// <para>备注</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>执行结果</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apply complete! Resources: 0 added, 0 changed, 0 destroyed.</para>
        /// </summary>
        [NameInMap("jobResult")]
        [Validation(Required=false)]
        public string JobResult { get; set; }

        /// <summary>
        /// <para>到达状态时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-13 17:11:34</para>
        /// </summary>
        [NameInMap("timeStamps")]
        [Validation(Required=false)]
        public string TimeStamps { get; set; }

        /// <summary>
        /// <para>错误详情</para>
        /// 
        /// <b>Example:</b>
        /// <para>Error：Cannot import non-existent remote object</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

    }

}

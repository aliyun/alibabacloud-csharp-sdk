// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListUserDrawRecordByPkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1789095186553536</para>
        /// </summary>
        [NameInMap("aliyunPk")]
        [Validation(Required=false)]
        public string AliyunPk { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>task_group_0000</para>
        /// </summary>
        [NameInMap("drawGroup")]
        [Validation(Required=false)]
        public string DrawGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>developer-award-draw-pool_123</para>
        /// </summary>
        [NameInMap("drawPoolName")]
        [Validation(Required=false)]
        public string DrawPoolName { get; set; }

    }

}

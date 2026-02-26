// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckInstanceExistResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the instance exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance exists.</description></item>
        /// <item><description><b>false</b>: The instance does not exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsExistInstance")]
        [Validation(Required=false)]
        public bool? IsExistInstance { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11439B36-F703-49EB-8656-D3C87BE28B57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

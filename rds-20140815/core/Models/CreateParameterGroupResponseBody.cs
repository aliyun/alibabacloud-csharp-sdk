// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter template ID. You can call the <a href="https://help.aliyun.com/document_detail/144491.html">DescribeParameterGroups</a> operation to query the parameter template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-q488w14xvsk****</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A41C147-C8D0-4DAE-A1A2-17EBCD60DFA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

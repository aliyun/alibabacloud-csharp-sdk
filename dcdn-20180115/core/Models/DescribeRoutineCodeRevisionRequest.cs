// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeRoutineCodeRevisionRequest : TeaModel {
        /// <summary>
        /// <para>The name of the routine. The name must be unique among the routines that belong to the same Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The version of the JavaScript code that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1611151912787121550</para>
        /// </summary>
        [NameInMap("SelectCodeRevision")]
        [Validation(Required=false)]
        public string SelectCodeRevision { get; set; }

    }

}

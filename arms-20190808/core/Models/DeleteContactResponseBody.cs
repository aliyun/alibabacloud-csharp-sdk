// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteContactResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the alert contact is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The alert contact is deleted.</description></item>
        /// <item><description><c>false</c>: The alert contact is not deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C21AB7CF-B7AF-410F-BD61-82D1567F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

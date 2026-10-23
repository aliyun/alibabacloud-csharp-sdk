// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the generated order.</para>
        /// <remarks>
        /// <para>The order ID is returned only when you change the specifications of a subscription disk.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20413515388****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID for changing the disk specifications.</para>
        /// <remarks>
        /// <para>This parameter is not returned if you only modify the performance level (PL) of an enterprise SSD.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>t-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}

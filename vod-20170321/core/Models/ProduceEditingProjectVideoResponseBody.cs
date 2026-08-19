// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ProduceEditingProjectVideoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the produced video.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The video production operation synchronously returns the ID of the produced video.</description></item>
        /// <item><description>When MediaId is returned, the video production has entered the asynchronous processing phase.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>006204a11bb386bb25491f95f****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The online editing project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb2101bf24b4cb318787dc****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

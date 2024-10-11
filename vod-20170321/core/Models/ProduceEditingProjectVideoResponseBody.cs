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
        /// <item><description>This parameter is returned for each request.</description></item>
        /// <item><description>If a value is returned for this parameter, the video production task is being asynchronously processed.</description></item>
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
        /// <para>The ID of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb2101bf24b4cb318787dc****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

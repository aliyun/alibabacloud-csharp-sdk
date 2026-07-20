// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWaitingRoomPreviewPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The waiting room preview page URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://waitingroom.myalicdn.com/testxxxx">http://waitingroom.myalicdn.com/testxxxx</a></para>
        /// </summary>
        [NameInMap("PageUrl")]
        [Validation(Required=false)]
        public string PageUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9732E117-8A37-49FD-A36F-ABBB87556CA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

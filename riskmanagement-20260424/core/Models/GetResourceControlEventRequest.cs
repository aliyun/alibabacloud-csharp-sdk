// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetResourceControlEventRequest : TeaModel {
        /// <summary>
        /// <para>The language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>The alert event ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09C-2PpwIzkpx2zG2fuFrAH55CpJaTK</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The list of specified event IDs.</para>
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public List<string> EventIdList { get; set; }

    }

}

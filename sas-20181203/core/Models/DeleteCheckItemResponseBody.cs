// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteCheckItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of deleted custom check items.</para>
        /// </summary>
        [NameInMap("CheckItems")]
        [Validation(Required=false)]
        public List<DeleteCheckItemResponseBodyCheckItems> CheckItems { get; set; }
        public class DeleteCheckItemResponseBodyCheckItems : TeaModel {
            /// <summary>
            /// <para>The check item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000000001</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The check item name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCheckItemName</para>
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20456DD5-5CBF-5015-9173-12CA4246B***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

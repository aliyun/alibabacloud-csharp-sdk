// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class PublishObjectListRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The publish command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PublishCommand")]
        [Validation(Required=false)]
        public PublishObjectListRequestPublishCommand PublishCommand { get; set; }
        public class PublishObjectListRequestPublishCommand : TeaModel {
            /// <summary>
            /// <para>The publish comment. The maximum length is 1,024 characters.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Publish</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The list of submit record IDs for the items to be published. A maximum of 50 submit IDs are supported.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SubmitIdList")]
            [Validation(Required=false)]
            public List<long?> SubmitIdList { get; set; }

        }

    }

}

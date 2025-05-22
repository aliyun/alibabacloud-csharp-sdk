// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class BindProduceAuthorizationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1219541161213057,1219541161213059</para>
        /// </summary>
        [NameInMap("AuthorizedUserIds")]
        [Validation(Required=false)]
        public string AuthorizedUserIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P20210815211849000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esp.bookkeeping_ai</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

    }

}

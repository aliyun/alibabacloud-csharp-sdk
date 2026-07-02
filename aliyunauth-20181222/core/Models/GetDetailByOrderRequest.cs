// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliyunAuth20181222.Models
{
    public class GetDetailByOrderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Acceptor")]
        [Validation(Required=false)]
        public string Acceptor { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BizNo")]
        [Validation(Required=false)]
        public string BizNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("CheckAuthItems")]
        [Validation(Required=false)]
        public string CheckAuthItems { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EmpId")]
        [Validation(Required=false)]
        public string EmpId { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OptSource")]
        [Validation(Required=false)]
        public string OptSource { get; set; }

    }

}

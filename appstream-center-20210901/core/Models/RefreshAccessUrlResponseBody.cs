// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class RefreshAccessUrlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://wuying.aliyun.com/native-solution/cloud-flow/view?id=a-075nu7b9ynrpugvbm&token=67C7557D25540A9130B1ED81E806D4772A7DE693E6F377E3594179772B">https://wuying.aliyun.com/native-solution/cloud-flow/view?id=a-075nu7b9ynrpugvbm&amp;token=67C7557D25540A9130B1ED81E806D4772A7DE693E6F377E3594179772B</a>******</para>
        /// </summary>
        [NameInMap("AccessUrl")]
        [Validation(Required=false)]
        public string AccessUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

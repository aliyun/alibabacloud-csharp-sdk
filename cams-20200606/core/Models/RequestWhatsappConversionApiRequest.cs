// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class RequestWhatsappConversionApiRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>929399382</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1939848838</para>
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public string PageId { get; set; }

        [NameInMap("RequestData")]
        [Validation(Required=false)]
        public List<RequestWhatsappConversionApiRequestRequestData> RequestData { get; set; }
        public class RequestWhatsappConversionApiRequestRequestData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>business_messaging</para>
            /// </summary>
            [NameInMap("ActionSource")]
            [Validation(Required=false)]
            public string ActionSource { get; set; }

            [NameInMap("AppData")]
            [Validation(Required=false)]
            public Dictionary<string, object> AppData { get; set; }

            [NameInMap("CustomData")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomData { get; set; }

            [NameInMap("DataProcessingOptions")]
            [Validation(Required=false)]
            public List<string> DataProcessingOptions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataProcessingOptionsCountry")]
            [Validation(Required=false)]
            public long? DataProcessingOptionsCountry { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("DataProcessingOptionsState")]
            [Validation(Required=false)]
            public long? DataProcessingOptionsState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20029399299</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Purchase</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://alibaba.com">http://alibaba.com</a></para>
            /// </summary>
            [NameInMap("EventSourceUrl")]
            [Validation(Required=false)]
            public string EventSourceUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709201870</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>whatsapp</para>
            /// </summary>
            [NameInMap("MessagingChannel")]
            [Validation(Required=false)]
            public string MessagingChannel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OptOut")]
            [Validation(Required=false)]
            public bool? OptOut { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public Dictionary<string, object> UserData { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

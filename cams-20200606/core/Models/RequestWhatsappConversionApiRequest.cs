// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class RequestWhatsappConversionApiRequest : TeaModel {
        /// <summary>
        /// <para>The customer Space ID or instance ID.</para>
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
        /// <para>The Meta Page ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1939848838</para>
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public string PageId { get; set; }

        /// <summary>
        /// <para>The request data.</para>
        /// </summary>
        [NameInMap("RequestData")]
        [Validation(Required=false)]
        public List<RequestWhatsappConversionApiRequestRequestData> RequestData { get; set; }
        public class RequestWhatsappConversionApiRequestRequestData : TeaModel {
            /// <summary>
            /// <para>This field specifies where the conversion occurred. Knowing where the event occurred helps ensure that ads are delivered to the right audience. By using the Conversions API, you agree that the action_source parameter is accurate to the best of your knowledge.</para>
            /// <para>The values that you can send in the action_source field are as follows:</para>
            /// <list type="bullet">
            /// <item><description>email: The conversion occurred via email.</description></item>
            /// <item><description>website: The conversion occurred on a website.</description></item>
            /// <item><description>app: The conversion occurred on a shift app.</description></item>
            /// <item><description>phone_call: The conversion occurred over a phone call.</description></item>
            /// <item><description>chat: The conversion occurred via a messaging app, SMS, or online messaging feature.</description></item>
            /// <item><description>physical_store: The conversion occurred in person at an entity store.</description></item>
            /// <item><description>system_generated: The conversion occurred automatically, such as when you subscribe and set the renewal Settings to monthly automatic payment.</description></item>
            /// <item><description>other: The conversion occurred via other methods not listed in this topic.</description></item>
            /// </list>
            /// <para>Note: All action source values support ad performance measurement and custom audience creation. All action sources except physical_store support ad optimization.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>business_messaging</para>
            /// </summary>
            [NameInMap("ActionSource")]
            [Validation(Required=false)]
            public string ActionSource { get; set; }

            /// <summary>
            /// <para>Required parameters for app events.</para>
            /// <para>These parameters are used to share app data and device information with the Conversions API.</para>
            /// </summary>
            [NameInMap("AppData")]
            [Validation(Required=false)]
            public Dictionary<string, object> AppData { get; set; }

            /// <summary>
            /// <para>The map that contains additional business data for the event.</para>
            /// </summary>
            [NameInMap("CustomData")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomData { get; set; }

            /// <summary>
            /// <para>The processing options that you want to enable for a specific event. For Limited Data Use, the current valid value is LDU. You can send an empty array to explicitly specify that this event must not be processed with the Limited Data Use restrictions.</para>
            /// </summary>
            [NameInMap("DataProcessingOptions")]
            [Validation(Required=false)]
            public List<string> DataProcessingOptions { get; set; }

            /// <summary>
            /// <para>Required if you send LDU under data_processing_options. The country or region that you want to associate with this data processing option. Valid values: 1 (United States) or 0 (request geolocation for this event).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataProcessingOptionsCountry")]
            [Validation(Required=false)]
            public long? DataProcessingOptionsCountry { get; set; }

            /// <summary>
            /// <para>Required in certain cases. Refer to the notes below for details. The state or province that you want to associate with this data processing option. Valid values: 1000 (California) or 0 (request geolocation for this event).</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("DataProcessingOptionsState")]
            [Validation(Required=false)]
            public long? DataProcessingOptionsState { get; set; }

            /// <summary>
            /// <para>This ID can be any unique string chosen by the advertiser. The event_name and event_id parameters are used to deduplicate events sent by websites (via Meta Pixel), apps (via SDK or App Events API), and the Conversions API. Note that although event_id is marked as optional, we recommend that you use this parameter for event deduplication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20029399299</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>The name of a standard or custom event. This field is used to deduplicate events sent by websites (via Meta Pixel), apps (via SDK or App Events API), and the Conversions API. The event_id parameter is also used for deduplication.</para>
            /// </description></item>
            /// <item><description><para>For the same customer action, the event of a browser or app event should match the event_name of the server event. If a match is found between events sent within 48 hours, only the first event is considered. If server and browser or app events are received at almost the same time (within 5 minutes of each other), the browser or app event takes precedence. Learn more about deduplicating Pixel and server events.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Purchase</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The browser URL where the event occurred. The URL must start with http:// or https:// and match a verified domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://alibaba.com">http://alibaba.com</a></para>
            /// </summary>
            [NameInMap("EventSourceUrl")]
            [Validation(Required=false)]
            public string EventSourceUrl { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp in seconds that indicates the actual time when the event occurred. The specified time can be earlier than the time when you send the event to Facebook. This allows for batch processing and server performance optimization. You must send this timestamp in the Greenwich Mean Time (GMT) format.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709201870</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            /// <summary>
            /// <para>Required parameters for app events.</para>
            /// <para>Extended device information, such as the width and height of the screen. This parameter is an array with values separated by commas. When you use extinfo, all values are required and must be arranged in the following index order. If a value is missing, you must use an empty string as a placeholder.</para>
            /// </summary>
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtInfo { get; set; }

            /// <summary>
            /// <para>The source channel. Fixed value: whatsapp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>whatsapp</para>
            /// </summary>
            [NameInMap("MessagingChannel")]
            [Validation(Required=false)]
            public string MessagingChannel { get; set; }

            /// <summary>
            /// <para>Specifies whether the event should not be used for ad delivery optimization. If this parameter is set to true, the event can only be used for attribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OptOut")]
            [Validation(Required=false)]
            public bool? OptOut { get; set; }

            /// <summary>
            /// <para>The map that contains customer data.</para>
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

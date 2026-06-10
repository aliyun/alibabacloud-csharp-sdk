// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptRecordingRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID of the recording</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c209abb3-6804-4a75-b2c7-dd55c8c61b6a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of entries per page</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Recording ID list (JSON format), same as UuidsJson</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;d9fad189-760b-47b9-837f-aeabb4fc9109\&quot;]</para>
        /// </summary>
        [NameInMap("RefIdsJson")]
        [Validation(Required=false)]
        public string RefIdsJson { get; set; }

        /// <summary>
        /// <para>Scenario ID of the recording</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d004cfd2-6a81-491c-83c6-cbe186620c95</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>Search criteria: Search by recording name or content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您好</para>
        /// </summary>
        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        /// <summary>
        /// <para>Recording status</para>
        /// <list type="bullet">
        /// <item><description><para>Validating: 1</para>
        /// </description></item>
        /// <item><description><para>Validation failed: 2</para>
        /// </description></item>
        /// <item><description><para>Processing: 3</para>
        /// </description></item>
        /// <item><description><para>Processing failed: 4</para>
        /// </description></item>
        /// <item><description><para>Reviewing: 5</para>
        /// </description></item>
        /// <item><description><para>Review failed: 6</para>
        /// </description></item>
        /// <item><description><para>Publish failed: 7</para>
        /// </description></item>
        /// <item><description><para>Published: 8</para>
        /// </description></item>
        /// <item><description><para>Pending publish: 9</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///      &quot;8&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("StatesJson")]
        [Validation(Required=false)]
        public string StatesJson { get; set; }

        /// <summary>
        /// <para>Recording ID list</para>
        /// <remarks>
        /// <para>This is a list of unique recording IDs. If left blank, all recordings display.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;d17d5bfa-4972-4389-9718-f9602edabe48&quot;]</para>
        /// </summary>
        [NameInMap("UuidsJson")]
        [Validation(Required=false)]
        public string UuidsJson { get; set; }

    }

}

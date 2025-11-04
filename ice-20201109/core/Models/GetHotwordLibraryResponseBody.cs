// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetHotwordLibraryResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the hotword library was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-23T13:33:49Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The description of the hotword library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热词库描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the hotword library.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>05512043f49f697f7425</b></b></para>
        /// </summary>
        [NameInMap("HotwordLibraryId")]
        [Validation(Required=false)]
        public string HotwordLibraryId { get; set; }

        /// <summary>
        /// <para>The hotword list.</para>
        /// </summary>
        [NameInMap("Hotwords")]
        [Validation(Required=false)]
        public List<Hotword> Hotwords { get; set; }

        /// <summary>
        /// <para>The name of the hotword library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热词库名称</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The usage scenario of the hotword library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASR</para>
        /// </summary>
        [NameInMap("UsageScenario")]
        [Validation(Required=false)]
        public string UsageScenario { get; set; }

    }

}

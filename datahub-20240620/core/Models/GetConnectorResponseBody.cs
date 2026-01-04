// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Datahub20240620.Models
{
    public class GetConnectorResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;field1\&quot;,\&quot;field2\&quot;]</para>
        /// </summary>
        [NameInMap("ColumnFields")]
        [Validation(Required=false)]
        public string ColumnFields { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;TimestampUnit\&quot;:\&quot;MICROSECOND\&quot;,\&quot;PartitionConfig\&quot;:{\&quot;hh\&quot;:\&quot;%H\&quot;,\&quot;mm\&quot;:\&quot;%M\&quot;,\&quot;ds\&quot;:\&quot;%Y%m%d\&quot;},\&quot;Project\&quot;:\&quot;xxx\&quot;,\&quot;TimeRange\&quot;:15,\&quot;TimeZone\&quot;:\&quot;Asia/Shanghai\&quot;,\&quot;Table\&quot;:\&quot;xxx\&quot;,\&quot;OdpsEndpoint\&quot;:\&quot;xxx\&quot;,\&quot;AccessId\&quot;:\&quot;xxx\&quot;,\&quot;PartitionMode\&quot;:\&quot;SYSTEM_TIME\&quot;,\&quot;AuthMode\&quot;:\&quot;ak\&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c5e07a96-5069-4486-87c3-0d281951f772</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1724041098000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>270523390948438349</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-06-06 15:45:00</para>
        /// </summary>
        [NameInMap("DoneTime")]
        [Validation(Required=false)]
        public string DoneTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A20A7093-8FE0-058C-BE0C-3C8057D5F1A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1764123132492KO88A</para>
        /// </summary>
        [NameInMap("SubscriptionId")]
        [Validation(Required=false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_topic</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SINK_ODPS</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1724041098000</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}

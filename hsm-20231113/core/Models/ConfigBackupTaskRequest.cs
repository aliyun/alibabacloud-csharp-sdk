// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class ConfigBackupTaskRequest : TeaModel {
        /// <summary>
        /// <para>The backup time in the 24-hour format. Valid values: 1 to 24.</para>
        /// <para>Enumeration values:</para>
        /// <list type="bullet">
        /// <item><description>0</description></item>
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>4</description></item>
        /// <item><description>5</description></item>
        /// <item><description>6</description></item>
        /// <item><description>7</description></item>
        /// <item><description>8</description></item>
        /// <item><description>9</description></item>
        /// <item><description>10</description></item>
        /// <item><description>11</description></item>
        /// <item><description>12</description></item>
        /// <item><description>13</description></item>
        /// <item><description>14</description></item>
        /// <item><description>15</description></item>
        /// <item><description>16</description></item>
        /// <item><description>17</description></item>
        /// <item><description>18</description></item>
        /// <item><description>19</description></item>
        /// <item><description>20</description></item>
        /// <item><description>21</description></item>
        /// <item><description>22</description></item>
        /// <item><description>23</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("BackupHourInDay")]
        [Validation(Required=false)]
        public long? BackupHourInDay { get; set; }

        /// <summary>
        /// <para>The ID of the backup.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backup-173620705****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The automatic backup cycle. Unit: days. Valid values: 1, 3, 7, and 30.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public long? BackupPeriod { get; set; }

        /// <summary>
        /// <para>The IDs of images for which the manual backup mode is updated to the automatic backup mode.</para>
        /// </summary>
        [NameInMap("Manual2PeriodicList")]
        [Validation(Required=false)]
        public List<string> Manual2PeriodicList { get; set; }

        /// <summary>
        /// <para>The IDs of images for which the automatic backup mode is updated to the manual backup mode.</para>
        /// </summary>
        [NameInMap("Periodic2ManualList")]
        [Validation(Required=false)]
        public List<string> Periodic2ManualList { get; set; }

    }

}
